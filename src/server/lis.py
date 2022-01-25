import requests as req
import pics

# SERVER = "http://192.168.22.4:5000/"
SERVER = "http://192.168.0.114:5000/"
H3 = SERVER+'h3/'
SPI = H3+'spi'
FORTH = H3+'forth'
SCREND = 9


class Colors():
    pass


class Base():
    def __init__(self, endpoint):
        self.endpoint = endpoint

    def post(self, abytesarray=None, typ='str', json=None):
        if abytesarray is not None:
            json = {'type': typ, 'message': abytesarray}
        elif json is not None:
            pass
        else:
            raise ValueError('wrong parameter combination')

        resp = req.post(self.endpoint, json=json)

        if resp.ok:
            return resp.json()
        else:
            resp.raise_for_status()


class CBuf(Base):
    def sendstr(self, msg):
        self.post(msg)

    def sendts(self, abytesarray):
        self.post(abytesarray, typ='bytes')


CBUF = CBuf(SPI)

CYAN = (0, 255, 255)
RED = (255, 0, 0)
YELLOW = (255, 255, 0)
GREEN = (0, 255, 0)


class TFTInterface(Base):
    def __init__(self, cbuf, vno=6):
        self.vno = vno
        self.cbuf = cbuf
        super().__init__(FORTH)
        # R, G, B
        self.bg = (0, 0, 0)
        fg = self.fg = Colors()
        fg.basic = YELLOW
        fg.patient = CYAN
        # fg.condition = (0, 255, 255)
        fg.condition = (0, 0, 255)
        fg.lead = GREEN

    def setfg(self, color):
        (r, g, b) = color
        self.cmd('{} {} {} tft-f!'.format(255-b, 255-g, 255-r))

    def setbg(self, color):
        (r, g, b) = color
        self.cmd('{} {} {} tft-b!'.format(255-b, 255-g, 255-r))

    def cmd(self, cmd):
        assert (self.post(json={'command': cmd})['rc'] == 'OK')

    def locate(self, x, y):
        self.cmd('{} {} tft-locate'.format(y, x))

    def type(self, s):
        n = len(s)
        self.cbuf.sendstr(s)
        self.cmd('CBUF {} tft-type'.format(n))

    def patient(self, name, id):
        self.locate(0, 0)
        self.setfg(self.fg.basic)
        self.type('Patient:')
        self.setfg(self.fg.patient)
        self.type(name + ' ')
        self.setfg(self.fg.basic)
        self.type('ID:')
        self.setfg(self.fg.patient)
        self.type(str(id))

    def condition(self, date, time, doctor):
        self.locate(0, SCREND)
        self.setfg(self.fg.basic)
        self.type('Date:')
        self.setfg(self.fg.condition)
        self.type(str(date)+' ')
        self.setfg(self.fg.basic)
        self.type('Doctor:')
        self.setfg(self.fg.condition)
        self.type(doctor)
        self.locate(0, SCREND-1)
        self.setfg(self.fg.basic)
        self.type('Time:')
        self.setfg(self.fg.condition)
        self.type(str(time))

    def lead(self, n):
        self.locate(0, n+1)
        self.setfg(self.fg.basic)
        self.type('V{}:'.format(n+1))
        self.setfg(self.fg.lead)
        self.graphics(list(pics.as_binary(n)))

    def graphics(self, abytesarray):
        self.cbuf.sendts(abytesarray)
        self.cmd('CBUF {} tft-buf-draw'.format(len(abytesarray) // 4))

    def draw(self, name, id, date, time, doctor):
        self.setbg(self.bg)
        self.patient(name, id)
        self.condition(date, time, doctor)
        for n in range(self.vno):
            self.lead(n)
        self.setfg(self.fg.basic)

    def clear(self):
        self.setbg(self.bg)
        self.cmd('tft-clear')


if __name__ == '__main__':
    # CBUF.sendstr('Linux & Forth Rule!')

    # arr = pics.as_binary(0)
    # CBUF.sendts(list(arr))

    scr = TFTInterface(CBUF, 6)
    # scr.clear()
    scr.draw('Ivanov', 'IKT-181221', '2021-05-16', '13:15 GMT+8',  'Petrov')

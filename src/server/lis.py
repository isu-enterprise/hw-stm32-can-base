import requests as req
import pics

SERVER = "http://192.168.22.4:5000/"
H3 = SERVER+'h3/'
SPI = H3+'spi'


class CBuf():
    def sendstr(self, msg):
        self.post(msg)

    def sendts(self, abytesarray):
        self.post(abytesarray, typ='bytes')

    def post(self, abytesarray, typ='str'):
        resp = req.post(SPI, json={'type': typ, 'message': abytesarray})

        if resp.ok:
            return
        else:
            resp.raise_for_status()


CBUF = CBuf()

if __name__ == '__main__':
    # CBUF.sendstr('Linux & Forth Rule!')
    arr = pics.as_binary(0)
    CBUF.sendts(list(arr))

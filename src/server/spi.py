import spidev

st = None
SPEED=100000

def connect():
    global st
    st = spidev.SpiDev(0, 0)


def disconnect():
    global st
    st.close()


def transfer(abytearray):
    global st
    return st.xfer(abytearray, SPEED, 0, 8)

def tranfer_test():
    global st
    st.xfer([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 0, 8)
    st.xfer2([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 0, 8)
    st.xfer3([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 1000, 8)

transfer_test=tranfer_test

if __name__=='__main__':
    connect()
    transfer_test()
    disconnect()
    # 00000001  00000008  00000001  000000FF  000000F0

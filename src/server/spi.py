import spidev

st = None


def connect():
    global st
    st = spidev.SpiDev(0, 0)


def disconnect():
    global st
    st.close()


def tranfer_test():
    global st
    st.xfer([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 0, 8)
    st.xfer2([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 0, 8)
    st.xfer3([0x1, 0x8, 0xF0, 0x0F, 0xFF], 50000, 1000, 8)

    # 00000001  00000008  00000001  000000FF  000000F0

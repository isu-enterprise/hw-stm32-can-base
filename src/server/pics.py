from PIL import Image

BRNAMES = ['pics/V'+str(n+1)+'.png' for n in range(6)]
BR = [Image.open(name) for name in BRNAMES]


def test_pic():
    global BR
    # print(BR)
    BR[0].show()
    for y in range(30):
        for x in range(318):
            print(BR[0].getpixel((x, y)), end='')
        print()


def as_binary(n):
    global BR
    pic = BR[n]
    for x in range(pic.width):
        c = 0
        for y in range(pic.height):
            c <<= 1
            if pic.getpixel((x, y)) == 0:
                c |= 1
        bb = c.to_bytes(4, byteorder='little')
        for b in bb:
            yield b


def test_as_bytes():
    global BR
    for b in as_binary(0):
        print(hex(b), ' ', end='')


if __name__ == '__main__':
    # test_pic()
    test_as_bytes()

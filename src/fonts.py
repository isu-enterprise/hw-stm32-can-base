import itertools


def num():
    with open('./font16x30.fs') as i:
        for l in i:
            l = l.strip().strip(",")
            if not l or not l.startswith('$'):
                continue
            l=l.strip('$')
            # print(l)
            yield l.strip()

print ("""\ compiletoflash
create font16x30""")
k = True
for l1,l2 in itertools.pairwise(num()):
    if k:
        l1=l1[4:]
        l2=l2[4:]
        print ('  ${} ,'.format(l1+l2))
    k = not k

print("""compiletoram
""")

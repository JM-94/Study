import numpy as np
from ex01 import doA,doB,doC,doD,a,b
from ex02 import ex02_doA,ex02_doB,ex02_doC

# mylist.length ...

def print_hi(name):
    print(f'Hi, {name}')
    mylist = [1,2,3]
    mylist_np = np.array(mylist)
    print(mylist_np.size)
    print(mylist_np.dtype)
    print(mylist_np[2])


if __name__ == '__main__':
    # print_hi('PyCharm')
    # doA()
    # doB()
    # doC()
    # doD()
    # print('a',a)
    # print('b', b)
    # ex02_doA()
    # ex02_doB()
    ex02_doC()

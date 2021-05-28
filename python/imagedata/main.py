import numpy as np
from ex02 import doA

# mylist.length

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
    doC()
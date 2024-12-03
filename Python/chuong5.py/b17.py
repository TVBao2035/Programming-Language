n = int(input("Nhap kich thuoc cua hinh: "))

def giai_thua(n):
    if n == 0:
        return 1
    return n*giai_thua(n-1)

def to_hop(n,k):
    return int(giai_thua(n)/(giai_thua(k)*giai_thua(n-k)))
for i in range(0,n):
    for j in range(0,i+1):
        print(to_hop(i,j),end=" ")
    print()

  
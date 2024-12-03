s = int(input("Nhap kich thuoc cua hinh"))

def giaithua(n):
    if n == 0:
        return 1
    return n*giaithua(n-1)
def tohop(n,k):
    return int(giaithua(n)/(giaithua(k)*giaithua(n-k)))
for i in range(0,s):
    for j in range(0,i+1):
        print(tohop(i,j),end=" ")
    print()

n = int(input("nhap so luong phan tu tinh tong:"))
s =1
for i in range(1,n+1):
    a = int(input())
    s += ((-1)**i)*(a**2)
print(s)
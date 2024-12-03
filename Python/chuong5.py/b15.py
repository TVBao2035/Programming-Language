a = int(input("Nhap so a = "))
b = int(input("Nhap so b = "))
def ban_be(a,b):
    tong_a = 0
    tong_b = 0
    for i in range(1,a):
        if a%i == 0:
            tong_a += i
    for i in range(1,b):
        if b%i == 0:
            tong_b += i
    if tong_a == b and tong_b == a:
        return 1
    else:
        return 0
if ban_be(a,b):
    print(a," va ",b," la ban be")
else:
    print(a," va ",b," khong phai ban be")
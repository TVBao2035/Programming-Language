import math
a = float(input("nhap a = "))
b = float(input("nhap b = "))
c = float(input("nhap c = "))

if a==0:
    if b == 0:
        if c == 0:
            print("phuong trinh vo so nghiem")
        else:
            print("phuong trinh vo nghiem")
    else:
        print("phuong trinh co nghiem:",-c/b)
else:
    delta = b**2-4*a*c
    if delta > 0:
        x1 = -b+math.sqrt(delta)/2*a
        x2 = -b-math.sqrt(delta)/2*a
        print("phuong trinh co hai nghiem:")
        print("x1 = ",x1)
        print("x2 = ",x2)
    elif delta < 0:
        print("phuong trinh vo nghiem")
    else:
        print("phuong trinh co nghiem kep:",-b/2*a)
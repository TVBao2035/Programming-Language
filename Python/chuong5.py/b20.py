x = float(input("Nhap so thuc = "))
while x<0:
    print(x," Khong hop le (x>0).Nhap lai x !")
    x = float(input("Nhap so thuc = "))
y = int(input("Nhap so nguyen = "))
def x_mu_y(x,y):
    result = x
    for i in range(0,y-1):
        result *= x
    return result
print("Result = ",x_mu_y(x,y))
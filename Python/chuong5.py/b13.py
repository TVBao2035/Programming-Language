n = int(input("Nhap so can kiem tra: "))
def nguyen_to(n):
    count = 0
    for i in range(1,n+1):
        if n%i == 0:
            count += 1
    if count == 2:
        return 1
    return 0
if nguyen_to(n):
    print(n," la nguyen to")
else:
    print(n," khong phai nguyen to")
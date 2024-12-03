s = []
n = int(input("Nhap so luong phan tu cho list: "))
for i in range(0,n):
    s.append(int(input("Nhap gia tri: ")))
x = int(input("Nhap gia tri muon tim: "))
def tim_kiem(s,x,n):
    if x not in s:
        return 0
    return 1

if tim_kiem(s,x,n):
    print(x," co trong list")
else:
    print(x," khong co trong list")
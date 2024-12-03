s = []
n = int(input("Nhap so luong phan tu cua list: "))
for i in range(0,n):
    s.append(int(input("Nhap phan tu cho list: ")))

def vi_tri_min(s,n):
    min = 0
    for i in range(0,n):
        if s[min] >= s[i]:
            min = i
    return min
def vi_tri_max(s,n):
    max = 0
    for i in range(0,n):
        if s[max] <= s[i]:
            max = i
    return max

print("Vi tri phan tu nho nhat la: ",vi_tri_min(s,n))
print("Vi tri phan tu lan nhat la: ",vi_tri_max(s,n))

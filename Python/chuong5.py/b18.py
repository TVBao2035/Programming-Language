s = []
n = int(input("Nhap so luong phan tu "))
for i in range(0,n):
    s.append(int(input("Nhap gia tri phan tu: ")))
def sap_xep(s,n):
    for i in range(0,n-1):
        for j in range(i+1,n):
            if s[i]>s[j]:
                s[i],s[j] = s[j], s[i]
    return s
print(s)
print("List da sap xep la ",sap_xep(s,n))
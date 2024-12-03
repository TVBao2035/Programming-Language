n = int(input("Nhap so nguyen :"))
def tong(n):
    s = str(n)
    l = len(s)
    sum = 0
    for i in range(0,l):
        sum += int(s[i])
    return sum
print("Tong cac chu so cua ",n," la ",tong(n))
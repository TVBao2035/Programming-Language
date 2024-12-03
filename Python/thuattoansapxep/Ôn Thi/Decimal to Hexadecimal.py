def Num_to_letter(n):
    if n<10:
        return n
    else:
        if n==10:
            return 'A'
        elif n==11:
            return 'B'
        elif n ==12:
            return 'C'
        elif n==13:
            return 'D'
        elif n==14:
            return 'E'
        elif n==15:
            return 'F'

s = int(input("Nhap Ma Thap Phan:"))
arr = []
du = 0
while s!=0:
    arr.append(s%16)
    s = s//16
    du = 0
n = len(arr)-1
for i in range(0,n+1):
    print(Num_to_letter(arr[n-i]),end="")
print()


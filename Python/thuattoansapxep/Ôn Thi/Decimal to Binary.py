s = int(input("Nhap Ma Thap Phan:"))
residual = []
while s > 0:
    residual.append(s%2)
    s = s//2
n = len(residual)-1
binary =""
for i in range(0,n+1):
    binary = binary + str(residual[n-i])

print(binary)
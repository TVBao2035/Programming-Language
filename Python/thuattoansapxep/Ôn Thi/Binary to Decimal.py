s = input("Nhap Ma Nhi Phan:")
n= len(s)-1
decimal = 0
for i in range(0,n+1):
	decimal = decimal + ((2**i)*int(s[n-i]))
print(decimal)



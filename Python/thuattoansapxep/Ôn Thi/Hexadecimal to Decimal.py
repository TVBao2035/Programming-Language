def Letter_to_Num(i):
    if i=='A' or i=='a':
        return 10
    elif i=='B' or i=='b':
        return 11
    elif i=='C' or i=='c':
        return 12
    elif i=='D' or i=='d':
        return 13
    elif i=='E' or i=='e':
        return 14
    elif i=='F' or i=='f':
        return 15
    else:
        return int(i)
    
s = input("Nhap Ma Thap Luc Phan:")
n = len(s)-1
decimal = 0
for i in range(0,n+1):
    decimal = decimal + (Letter_to_Num(s[n-i])*(16**i))

print(decimal)
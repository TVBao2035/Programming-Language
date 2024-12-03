def binary_to_decimal(u):
    n = len(u)-1
    decimal = 0
    for i in range(0,n+1):
        decimal = decimal + (u[i]*(2**i))
    return decimal
def decimal_to_hex(u):
    if u < 10:
        return str(u)
    elif u == 10:
        return 'A'
    elif u == 11:
        return 'B'
    elif u == 12:
        return 'C'
    elif u == 13:
        return 'D'
    elif u == 14:
        return 'E'
    elif u == 15:
        return 'F'
s = input("Nhap Ma Nhi Phan:")
n = len(s)-1
arr = []
hex_fake=""
hexadecimal = ""
i = 0
while i <= n+1:
    if len(arr)<4:
        if i<len(s):
            arr.append(int(s[n-i]))
        if i == len(s):
            while len(arr)<4:
                arr.append(0)
            hex_fake += decimal_to_hex(binary_to_decimal(arr))
        i += 1
    else:
        hex_fake += decimal_to_hex(binary_to_decimal(arr))
        arr.clear()
        arr.append(int(s[n-i]))
        i +=1
m = len(hex_fake)-1
for i in range(0,len(hex_fake)):
    hexadecimal += hex_fake[m-i]
print("KQ=",hexadecimal)
    
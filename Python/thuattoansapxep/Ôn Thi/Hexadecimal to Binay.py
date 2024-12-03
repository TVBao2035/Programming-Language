def Hex_to_dec(i):
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
def Dec_to_bina(i):
    binary =""
    arr =[]
    while i>0:
        arr.append(i%2)
        i = i//2
    while len(arr)!=4:
        arr.append(0)
    n = len(arr)-1
    for i in range(0,n+1):
        binary = binary +str(arr[n-i])
    return binary
s = input("Nhap Ma Thap Luc Phan:")
hex_to_binary = ""
for i in range(0,len(s)):
    hex_to_binary = hex_to_binary + Dec_to_bina(Hex_to_dec(s[i]))
print(hex_to_binary)
print(len(hex_to_binary))
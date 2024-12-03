n = int(input("Enter the Number: "))
s = 1
a = 0
b = 0
for i in range(0,n):
    print(s)
    b = a
    a = s
    s = a + b


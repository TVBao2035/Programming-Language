n = int(input("Nhap n = "))
def in_nguyen_to(n):
    for i in range(1,n+1):
        count = 0
        for j in range(1,i+1):
            if i%j ==0:
                count += 1
        if count == 2:
            print(i)
in_nguyen_to(n)
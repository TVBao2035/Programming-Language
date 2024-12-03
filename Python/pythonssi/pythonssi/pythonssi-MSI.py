s = [10,5,4,8,6,7,1,3,9,2,0]
n = len(s)

#thuat toan meger sort
def Meger_sort(s):
    if len(s)>1: #xet neu mang it hon 1 se khong thuc thi 
        left = 0    #gan left vi tri dau tien cua mang
        right = len(s)  #gan right la vi tri cuoi cua mang
        mid = int((right + left)/2) #tinh vi tri mid 
        list_left = s[left:mid]    #gan mang s tu phan tu left den phan tu mid
        list_right = s[mid:right]   #gan mang s tu phan tu mid den phan tu right
        Meger_sort(list_left)   #dung thuat toan meger sort cho mang ben trai
        Meger_sort(list_right)    #dung thuat toan meger sort cho mang ben phai
        i = 0   #gan i la bien chay trong mang list_left
        j = 0   #gna j la bien chay trong mang list_right
        k = 0   #gan k la bien chay trong mang s
        while i < len(list_left) and j < len(list_right): 
            """nghia la neu i,j lon hon list_left, list_right thi da duyet het mang"""
            """kiem tra phan tu thu i cua list_left voi phan tu thu j cua list_right
            neu phan tu nao nho hon se them vao mang s o vi tri k"""
            if list_left[i] < list_right[j]: 
                s[k] = list_left[i]
                i += 1
            else:
                s[k] = list_right[j]
                j += 1 
            k += 1 
        #kiem tra nhung phan tu van con trong mang list_left hoac mang list_right 
        while i < len(list_left): #cho het phan tu cua list_left vao s
            s[k] = list_left[i]
            k += 1
            i += 1
        while j < len(list_right): #cho het phan tu cua list_right vao s 
            s[k] = list_right[j]
            j += 1
            k += 1
    return s
# thuat toan insertion sort
def Insertion_sort(s):
    for i in range (0,n):
        k = s[i] #gan k bang phan tu thu i 
        j = i - 1 #gan j co gia tri nho hon i 1 don vi
        while k < s[j] and j >=0 :#neu j < 0 thi k = s[i] va neu k > s[j] thi k = s[j]
            s[j+1] = s[j] #gan s[j+1] bang voi s[j]
            j -= 1 #giam j xuong 1 don vi
        s[j+1] = k #gan s[j+1] = k khi kiem tra xong mang
    return s

#thuat toan selection sort
def Selection_sort(s):
    for i in range(0,n-1):
        minplace = i #tao bien minplace bang vi tri i
        for j in range(i+1,n):
            if s[minplace] > s[j]: #kiem tra phan gia tri tu thu minplace co lon hon phan tu thu j khong 
                minplace = j # cap nhat lai gia tri cho minplace bang vi tri co gia tri nho hon
        s[minplace],s[i] = s[i], s[minplace]#hoan doi phan tu o vi tri minplace voi phan tu o vi tri i
    return s

#thuat toan bubble sort
def Bubble_sort(s):
    for i in range(0,n-1):
        for j in range(i+1,n):
            if s[i] > s[j]:#kiem tra phan tu o vi tri i va phan tu o vi tri j phan tu nao nho hon
                s[i],s[j] = s[j],s[i]#hoan doi gia tri o vi tri i va gia tri o vi tri j
    return s

print("Thuat toan bubble sort ",Bubble_sort(s))
print("Thuat toan selection sort ",Selection_sort(s))




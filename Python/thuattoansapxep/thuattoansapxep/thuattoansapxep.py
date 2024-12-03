arr = [9,5,4,3,7,6,8,2,1,0]
n = len(arr)
#Thuat toan Meger sort
def Meger_sort(arr):
    if(len(arr)>1):
        left = 0
        right = len(arr)
        mid = int((left+right)/2)
        arr_left = arr[left:mid]
        arr_right = arr[mid:right]
        Meger_sort(arr_left)
        print("danh sach left",arr_left)
        Meger_sort(arr_right)
        print("danh sach right",arr_right)
        x = y = z =0
        while x < len(arr_left) and y < len(arr_right):
            if arr_left[x]<arr_right[y]:
                arr[z] = arr_left[x]
                x += 1
                print("left",arr)
            else:
                arr[z] = arr_right[y]
                y += 1
                print("right",arr)
            z += 1
        while x < len(arr_left):
            arr[z] = arr_left[x]
            x += 1
            z += 1
            print("leftl",arr)
        while y < len(arr_right):
            arr[z] = arr_right[y]
            z += 1
            y += 1
            print("rightl",arr)
    return arr
#thuat toan bubble sort
def Bubble_sort(arr,n):
    for i in range(0,n-1):
        for j in range(i+1,n):
            if arr[i] > arr[j]:
                arr[i], arr[j] = arr[j], arr[i]
    return arr
#thuat toan selection sort
def Selection_sort(arr,n):
    for i in range(0,n-1):
        k = i
        for j in range(i+1,n):
            if arr[k] > arr[j]:
                k = j
        arr[k], arr[i] = arr[i], arr[k]
    return arr
#thuat toan insertion sort
def Insertion_sort(arr,n):
    for i in range(0,n):
        k = arr[i]
        j = i-1
        while k < arr[j] and j >= 0:
            arr[j+1] = arr[j]
            j -= 1
            print(arr)
        arr[j+1] = k
        print(arr)
    return arr
print(arr)
print(Meger_sort(arr))
#print(Bubble_sort(arr,n))
#print(Selection_sort(arr,n))
#print(Insertion_sort(arr,n))

n =int(input("Nhap so can doc nguoc: "))

def so_doc_nguoc(n):
    s = str(n)
    letter = ""
    for i in range(0,len(s)):
        letter += s[len(s)-1-i]
    return int(letter)
print(n," doc nguoc la ",so_doc_nguoc(n))
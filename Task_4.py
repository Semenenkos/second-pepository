# Задача 4. 
# Задать список из N элементов, заполненных числами из [-N, N]. 
# Найти произведение элементов на указанных позициях. 
# Позиции хранятся в файле file.txt в одной строке одно число.

import random
def write_file(number):
    with open('file.txt', 'w') as data:
        for i in range(number):
            data.write(f"{random.randrange(0, 2*number)}\n")

def read_file():
    with open('file.txt', 'r') as data:
        index = list(map(int,data.readlines()))
    return index

n = int(input("Enter a number N: "))
x_n = [i for i in range(-n, n+1)]
write_file(n)
x_i = read_file()
ProductOfElements = 1
for i in range(len(x_i)):
    ProductOfElements *= x_n[x_i[i]]
print(f"The product of elements is equal to = {ProductOfElements}")
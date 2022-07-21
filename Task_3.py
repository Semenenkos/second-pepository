# Задача 3.
# Задайте список из n чисел последовательности (1+1/n)^n и вывести на экран их сумму.

n = int(input("Enter a list of numbers: "))
s = 0
for i in range(1, n+1):
    s += (1+1/i)**i
print(f"The sum of the sequence numbers (1+1/n)^n is {round(s, 2)}")
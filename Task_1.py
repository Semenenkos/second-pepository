# Задача 1. 
# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# 67,82 -> 23
# 0,56 -> 11

real_number = input('Enter a real number: ')
print(type(real_number))
sum = 0
for i in real_number:
    if i != '.':
        sum += int(i)
print(sum)
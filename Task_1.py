# Задача 1
# Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
# Пример: - 6 -> да - 7 -> да - 1 -> нет

day = int(input('Enter a number representing the day of he week: '))
if day > 7 or day < 1:
    print('This number is not a day of the week. Please enter another number')
elif day == 6 or day == 7:
    print("Yes, it's weekend!")
else:
    print("No, it's not weekend!")
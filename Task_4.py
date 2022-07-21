# Задача 4. 
# Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
# Пример:
# A (3,6); B (2,1) -> 5,09
# A (7,-5); B (1,-1) -> 7,21

print('Enter point2D А coordinates:')
x_A = float(input('X: '))
y_A = float(input('Y: '))
print('Enter point2D B coordinates:')
x_B = float(input('X: '))
y_B = float(input('Y: '))

from math import sqrt
print('Distance between points in 2D space: ',round(sqrt((x_B - x_A)**2 + (y_B - y_A)**2), 2))
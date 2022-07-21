# Задача 5. 
# Реализовать алгоритм перемешивания списка.

import random
algorithm = [random.randint(0,9) for i in range(random.randint(5,10))]
print(f"initial list:\n {algorithm}")
random.shuffle(algorithm)
print(f"shuffle list:\n{algorithm}")
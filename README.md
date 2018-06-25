# solvepoly-2
Из Main() вызывается только два метода (так удобнее для целей тестирования): метод расчёта и метод вывода, первому передаются параметры командной строки, из него возвращается все результаты, а второму передаются результаты и параметры командной строки, и он выводит их так, как указано в параметрах.


``` cmd
> solvepoly 1 -1 -1
1.6180
-0.6180
```
 Также программа имеет в качестве входного параметра ключ `-v`. 
 
 Вывод при этом должен выглядить так:

``` cmd
> solvepoly -v 1 -1 -1
*** Input ***
Polynom of degree 2
x^2-x-1=0
*** Solution ***
Solving by quadratic formula:
Discriminant:
    D = b^2-4ac
    D = (-1)^2-4*(1)*(-1) = 5
Roots:
    D > 0, must be 2 roots
    x1,2 = (-b±√D)/(2a)
    x1 = (1+√5)/(2*1) = 1.6180
    x2 = (1-√5)/(2*1) = -0.6180
*** Results ***
1.6180
-0.6180
```

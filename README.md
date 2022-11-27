# Итоговый проект по теме "Итоги блока. Выбор специализации".

## Студент: Москалев Н.А.

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Требования к решению задачи и вся дополнительная информация указаны на рисунке ниже:

![Задача на итоговый проект](FinalTask.png "картинка с сайта GeekBrains")

### Этапы решения задачи:

1. Написать метод ввода/получения данных;
2. Написать метод обработки данных (выборку строк с количеством элементов меньше или равным 3);
3. Написать метод вывода результата;

### Расширения по задаче:
* Добавить переменную для фильтрации по меньшему или равному определенному кол-ву элементов в элементе массива строк

### Возможные проблемы:
* Проверкой для окончания ввода данных является ввод строки "exit input" и если пользователю понадобиться ввести именно эту фразу, а затем ещё какие-либо строковые данные, то ввод закочнится после "exit input".

    *Возможные решения проблемы: если заведомо знать кол-во вводимых строковых данных, то поставить условие на количество, также можно реализовать повторный ввод данных, то есть если в консоль введено такая же строка, что и ранее, то цикл обрываем.*

    Хотя всё равно можно подобрать ситуации при которых вышеперечисленные решения не сработают.
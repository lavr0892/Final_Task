**Итоговая проверочная работа.**

Необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описание решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

*Задача:* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


*Алгоритм решения задачи*:

Я созадала два массива. Один необходим для первоначально введенных строк. Во второй массив отсортировывались только те строки, которые меньше или равны 3 элементам. Создала функцию, где происходит сама сортировка. Для сортировки добавила переменную count. Если строка меньше или равена 3 элементам, то она заносится в count строк второго массива. После count увеличивается на 1, возвращаемся к for, где i увеличивается на 1. И так доходим до конца цикла.
В данной задаче я сделала ввод строк с клавиатуры.
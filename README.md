Zadanie_1.4
===========
###Задание:
Дано предложение. Определить длину его самого короткого слова и номер этого слова в предложении.

`string[] slova = words.Split(new Char[] { ' ', ',', '.', ':', '\t','!','?','&','-',';' });`  -  в данной строке реализуется метод **String.Split**,результатом использования которого становится массив,элементами которого являются слова,разделенные заданным массивом символов.
<pre><code>foreach(string raz in slova)
            {
                x[i]=raz.Length;
                i++;
            }</code></pre>  Далее используется свойство **String.Length**,которое возвращает число знаков или элементов в текущем элементе **String**.В данном случае в массив *[] x* переписывается длина(*чило знаков*) каждого элемента массива **slova**,т.е. длина каждого слова.Массив *[] x* имеет размер,равный числу слов,т.е. числу элементов массива **slova** :` int[] x = new int[slova.Length];`
            
####Результат работы программы:
<a target="_blank" href="http://fastpic.ru"><img src="http://i61.fastpic.ru/big/2014/0704/3a/519f17c4fede20e33c49b6dc6601fa3a.jpg" border="0"></a>

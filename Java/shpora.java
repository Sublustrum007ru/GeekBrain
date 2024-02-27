public class shpora  //  Строка открытия программы "program" - название файла с кодом. Обязательная строка
{
    public static void main(String[] args) {    //Строка начала основного кода, как правило называется "main". Здесь указываются входные данные
        Object o = 1; GetType(o);
        o = 1.2; GetType(o);
    }
    static void GetType(Object obj){         // Стока начало метода/функции. Само ыполнение кода
        System.out.println(obj.getClass().getName());
    }
}
// для вывода массива в консоль, нода импортировать модуль
// import java.util.Arrays;
// Затем в коде ввести System.out.println(Arrays.toString(array));
   M S B A M L   `   `   `  ����J  FFirstAppMiusova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FirstAppMiusova.PagesFirstAppMiusova.Pages  5      #    FirstAppMiusova.Pages.PagePR6   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FirstAppMiusova.Pages     5        N� Title$  PagePR6��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��6* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� .+�5      �� $����Задание: Дана строка символов, содержащая некоторый текст на русском языке. Заменить все большие буквы ‘А’ на символ ‘*’. ��6      TxtStyleTaskPR#��[  5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5      $��1��5      .+�5      �� -   5        $��LstInputPR6��5      $	��500��5      $	��190��6"   5      �� 5   
   $ 
Horizontal=�6   $��Center=�5      $��2��5       .+�5!      �� -   5        $��	TxbRezult��5!      $,��&Количество пробелов:��5"        TxtStyleResultPR#��[ 5#      5$      �� 5%   
   $ 
Horizontal=�6   $��Center=�5&      $��3��5'      .+�5(      �� -   5        $��BtnListFromFilePR6��5(      $"��Список из файла��5)        
BtnStylePR#��[ 5*      $��0 0 10 0q�5+      5,      �� 5-      -   5        $��BtnResultPR6��5-      $��Результат��5.      #��[ 5/      $��0 0 10 0q�50      51      �� 52      -   5        $��BtnClearPR6��52      $��Очистить��53      #��[ 54      $��0 0 10 0q�55      56      57      �� 58   
   $ 
Horizontal=�6   $��Center=�59      $��4��5:      .+�5;      �� -   5        $��
BtnBackPR6��5;      $��
Назад��5<      #��[ 5=      $��0 0 10 0q�5>      5?      �� 5@      -   5        $��
BtnNextPR6��5@      $��
Далее��5A      #��[ 5B      $��0 0 10 0q�5C      5D      5E      5F      5G      
   M S B A M L   `   `   `  ����J  FFirstAppMiusova, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FirstAppMiusova.PagesFirstAppMiusova.Pages  5      #    FirstAppMiusova.Pages.PagePR1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FirstAppMiusova.Pages     5        N� Title$  PagePR1��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $����Задание: составить программу вычисления для заданных значений x, y, z арифметического выражения. ��6      TxtStyleTaskPR#��[  5      �� 5      5      �� 5   
   $ 
Horizontal=�6   $��Center=�5      $��1��5      .+�5      �� $��Введите X:��6     TxtInputStylePR#��[ 5      �� 5      -   5        $��TxtPR1X��5      $��25��5       $	��150��6"   5!      �� 5"   
   $ 
Horizontal=�6   $��Center=�5#      $��2��5$      .+�5%      �� $��Введите Y:��6   #��[ 5&      �� 5'      -   5        $��TxtPR1Y��5'      $��25��5(      $	��150��6"   5)      �� 5*   
   $ 
Horizontal=�6   $��Center=�5+      $��3��5,      .+�5-      �� $��Введите Z:��6   #��[ 5.      �� 5/      -   5        $��TxtPR1Z��5/      $��25��50      $	��150��6"   51      �� 52   
   $ Vertical=�6   $��Center=�53      $��4��54      .+�55      �� $��Результат:��6     TxtStyleResultPR#��[ 56      �� 57      -   5        $��LstResultPR1��57      $	��250��58      $	��100��59      5:      5;      �� 5<   
   -   5        $��BtnSolvePR1��5<        
BtnStylePR#��[ 5=      $��Выполнить��5>      $��5��5?      5@      �� 5A   
   -   5        $��
BtnNextPR1��5A      #��[ 5B      $��
Далее��5C      $��6��5D      5E      5F      5G      
   M S B A M L   `   `   `  ����I  ENotarialHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:NotarialHelper.Pages.DealPagesNotarialHelper.Pages.DealPages  5   	   /    )NotarialHelper.Pages.DealPages.RecordDeal   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:NotarialHelper.Pages.DealPages     5   	     � Title$  
RecordDeal��5   	   $	��440��6   $	��440��6,   $	��440��6;   $	��440��6H    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � -   5         � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6   $��2��6-   $��Center=�6A   $��Center=�6^   $��Bahnschrift SemiBold)�6y   $��14(�6�   .��6�   31Введите полное имя клиента6�   �� 5   
   -   5         ��Name$ FullNameClientTextBox��5      $��2��61   $��1��6>   $��2��6N   $��10 12 10 12q�6b   $��Bahnschrift SemiBold)�6w   $��14(�6�   �� 5!   
   $��3��6   $��1��6   $��2��6-   $��Center=�6A   $	��Top=�6^   $��Bahnschrift SemiBold)�6v   $��14(�6�   .��6�   Услуга:6�   �� 5"   
   -   5        $ ServiceNameTextBox��5"      $��3��6.   $��1��6;   $��2��6K   $��
10 12 10 1q�6_   $��Bahnschrift SemiBold)�6s   $��14(�6�   $��Bottom=�6�   �� 5%   
   $��4��6   $��1��6   $��Center=�6-   $	��Top=�6J   $��Bahnschrift SemiBold)�6b   $��14(�6�   .��6�   Сумма:6�   �� 5&   
   -   5        $ 
SumTextBox��5&      $��4��6&   $��1��63   $��
10 10 10 0q�6C   $��Bahnschrift SemiBold)�6W   $��14(�6y   $��Bottom=�6�   �� 5)   
   $��5��6   $��1��6   $
��Left=�6-   $��Bottom=�6H   $��Bahnschrift SemiBold)�6c   $��14(�6�   .��6�   Коментарий:6�   �� 5*   
   -   5        $ DescriptopnTextBox��5*      $��6��6.   $��1��6;   $��2��6K   $��5,5,5,0q�6`   $��Bahnschrift SemiBold)�6q   $��14(�6�   $	��Top=�6�    �� TextWrapping$
 Wrap=�6�   $��36��6�   �� 5-   
   $��4��6   $��2��6   $��Center=�6-   $	��Top=�6J   $��Bahnschrift SemiBold)�6b   $��14(�6�   .��6�   Сумма:6�   �� 5.   
   -   5        $ ComissionTextBox��5.      $��4��6,   $��2��69   $��5 12 5 0q�6I   $��Bahnschrift SemiBold)�6[   $��14(�6}   $��Bottom=�6�   �� 50   
   -   5         ��Name$ NextInputDataButton��50      $��Добавить��6.   $��7��6A   $��1��6N   $��Center=�6^   $��Center=�6y   $��30��6�   $	��120��6�   $��Bahnschrift SemiBold)�6�   $��14(�6�   
�������
�������6  �� 51   
   -   5        $ ClosePageButton��51      $��Закрыть��6*   $��7��6<   $��2��6I   $��Center=�6Y   $��Center=�6t   $��30��6�   $	��120��6�   $��14(�6�   $��Bahnschrift SemiBold)�6�   
�������
�������6  52      53      
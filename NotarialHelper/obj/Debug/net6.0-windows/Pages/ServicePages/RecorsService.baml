   M S B A M L   `   `   `  ����I  ENotarialHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:NotarialHelper.Pages.ServicePages!NotarialHelper.Pages.ServicePages  5   	   5    /NotarialHelper.Pages.ServicePages.RecorsService   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:NotarialHelper.Pages.ServicePages     5   	     � Title$  RecorsService��5   	   $	��450��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � -   5         � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6   $��2��6-   $��Center=�6A   $��Center=�6^   $��Bahnschrift SemiBold)�6y   $��14(�6�   .��6�   31Введите полное имя клиента6�   �� 5   
   -   5         ��Name$ FullNameTextBox��5      $��2��6+   $��1��68   $��2��6H   $��10 12 10 12q�6\   $��Bahnschrift SemiBold)�6q   $��14(�6�   �� 5    
   $��3��6   $��1��6   $��2��6-   $
��Left=�6A   $��Bottom=�6\   $��Bahnschrift SemiBold)�6w   $��14(�6�   .��6�   " Вид деятельности:6�   �� 5!   
   -   5        $ ActivityTextBox��5!      $��4��6+   $��1��68   $��	5 12 5 12q�6H   $��Bahnschrift SemiBold)�6[   $��14(�6}   $	��Top=�6�   �� 5$   
   $��5��6   $��1��6   $��2��6-   $��Center=�6A   $	��Top=�6^   $��Bahnschrift SemiBold)�6v   $��14(�6�   .��6�   Номер телефона:6�   �� 5%   
   -   5        $ PhoneTextBox��5%      $��5��6(   $��1��65   $��2��6E   $��
10 10 10 0q�6Y   $��Bahnschrift SemiBold)�6m   $��14(�6�   $��Bottom=�6�   �� 5(   
   $��3��6   $��2��6   $��Center=�6-   $��Bottom=�6J   $��Bahnschrift SemiBold)�6e   $��14(�6�   .��6�   Адресс:6�   �� 5)   
   -   5        $ AdressTextBox��5)      $��4��6)   $��2��66   $��	5 12 5 12q�6F   $��Bahnschrift SemiBold)�6Y   $��14(�6{   $	��Top=�6�   �� 5+   
   -   5         ��Name$ NextInputDataButton��5+      $��Добавить��6.   $��7��6A   $��1��6N   $��Center=�6^   $��Center=�6y   $��30��6�   $	��120��6�   $��Bahnschrift SemiBold)�6�   $��14(�6�   
�������
�������6�   �� 5,   
   -   5        $ ClosePageButton��5,      $��Закрыть��6*   $��7��6<   $��2��6I   $��Center=�6Y   $��Center=�6t   $��30��6�   $	��120��6�   $��14(�6�   $��Bahnschrift SemiBold)�6�   
�������
�������6�   5-      5.      
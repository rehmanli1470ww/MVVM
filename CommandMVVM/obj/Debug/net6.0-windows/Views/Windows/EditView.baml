   M S B A M L   `   `   `  ����F  BCommandMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CommandMVVM.Views.WindowsCommandMVVM.Views.Windows  5   	   (    "CommandMVVM.Views.Windows.EditView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CommandMVVM.Views.Windows     5   	     � Title$  EditView��5   	   $	��450��6   $	��800��6'   .��5	      � 
�������.+�5   
   �� $��Center=�6   $	��500��60   $��10q�6<   .+�5      �� $��
5 20 10 20q�6    �� Orientation$ 
Horizontal=�6-   .+�5      �� $��70��6   $
��Make��6#   $��0 0 20 0q�62   $��18(�6F   �� 5      $	��400��5      $��0 0 10 0q�6!   $��18(�64   $��Right=�6B   ��5      �� *
car.Make+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5   B   5      �� 5      $��
5 20 10 20q�6   $ 
Horizontal=�6-   .+�5      �� $��70��6   $��Model��6#   $��0 0 20 0q�63   $��18(�6F   �� 5      $	��400��5      $��0 0 10 0q�6!   $��18(�64   $��Right=�6B   ��5      �� *	car.Model+$ TwoWay=�$ PropertyChanged=�5   B   5      �� 5      $��
5 20 10 20q�6   $ 
Horizontal=�6-   .+�5      �� $��70��6   $
��Year��6#   $��0 0 20 0q�62   $��18(�6E   �� 5      $	��400��5       $��0 0 10 0q�6!   $��18(�64   $��Right=�6B   ��5      �� *
car.Year+$ TwoWay=�$ PropertyChanged=�5    B   5!      �� 5$      $��Center=�6   $ 
Horizontal=�67   .+�5%      �� -   5        $
��Save��5(   =   $	��100��6   $��10q�6"   $
��Save��6.   ��5&      �� *SaveCommand+��5'      ��  �� RelativeSource �� *Self+5(   =   �� 5*      $	��100��6   $��10q�6&   $��Cancel��62   ��6C   �� *CancelAllCommand+��6h   ��  ��  �� AncestorType" �5+      5-      5/      50      
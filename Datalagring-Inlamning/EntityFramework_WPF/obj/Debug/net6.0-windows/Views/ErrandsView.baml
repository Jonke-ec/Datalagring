   M S B A M L   `   `   `  ����N  JEntityFramework_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EntityFramework_WPF.ViewsEntityFramework_WPF.Views  5      +    %EntityFramework_WPF.Views.ErrandsView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EntityFramework_WPF.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��	Kundlista��6,   $��18(�6=   $
��Left=�6K   $��7q�6f   $��Center=�6q   5      � 5      $��7q�6    5      �� 5      $
��0.5* �6'   �� 5      $
��0.8* �6'   �� 5      $��2* �6'   �� 5      $
��0.8* �6'   �� 5      $��1* �6'   .+�5"      �� $��0��6   $��Kund ID��6,   �� 5#      $��1��6   $��Rubrik��6,   �� 5$      $��2��6   $��Beskrivning��6,   �� 5%      $��3��6   $��Status��6,   �� 5&      $��4��6   $��Datum��6,   5'      5(      �� 5+   
   -   5         ��Name$ 	lvErrands��5+       � DataContext$ Wpf.Models.Subject��6&   $��1��6G   
������ $��Stretch=�6m   $��Stretch=�6�   ��5,      �� 5-      .R�5.      �  5/      �� 50      $
��0.5* �6/   �� 51      $
��0.8* �6/   �� 52      $��2* �6/   �� 53      $
��0.8* �6/   �� 54      $��1* �6/   .+�57      �� $��0��6$   ��64   �� *
CustomerId+�� 58      $��1��6$   ��64   �� *ErrandTitle+�� 59      $��2��6$   ��64   �� *Description+�� 5:      $��3��6$   ��64   �� *Status+�� 5;      $��4��6$   ��64   �� *
ErrandDate+5<      5=      5?      5@      5A      
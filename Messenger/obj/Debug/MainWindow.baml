   M S B A M L   `   `   `  ����D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Messenger	Messenger  5   	       Messenger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Messenger     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��159* �6   �� 5      $
��260* �6    � ColumnDefinitions 5   
   �� 5      $
��318* �6   �� 5      $
��355* �6   �� 5      $
��119* �6   .+�5   
   �� -   5        $��panel��5      $��10,10,0,111q�6   $��2��64   $��2��6H   $
��Left=�6Y   $	��616��6t   {�.  .��6�   5      �� 5   
   $��
0,0,92,132q�6   $
��Wrap=�6(   $��	Nickname:��6<   $��1��6M   $��Right=�6]   $��56��6y   $��2��6�   $��16��6�   $��Bottom=�6�   �� 5   
   -   5        $��Nickname��5      $��Right=�6"   $��
0,0,28,104q�6>    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��120��6n   $��1��6z   $��23��6�   $��Bottom=�6�   $��2��6�   � 5   
   $��3��6   $��10,150,43,10q�6#   $��1��69   .+�5      �� $
��Send��6   $��
621,0,0,69q�6$   $��22��68   $��Bottom=�6D   $
��Left=�6_   $��88��6z    J� IsManipulationEnabled . 6�   �� 5      -   5        $
��Pole��5      $
 Wrap=�6"   $
��Left=�66   $	��616��6Q   $��93��6]   $��Bottom=�6i   5      5      5      
   M S B A M L   `   `   `  ����N  JBirthdayReminderWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BirthdayReminderWpf.ViewBirthdayReminderWpf.View  5   	   +    %BirthdayReminderWpf.View.PersonWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:BirthdayReminderWpf.View     5   	   $	��400��5	   	   $	��500��6     � AllowsTransparency$
  True��5
   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ Manual=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%F  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 	Helvetica)�6+   �� 5       � ��$ 20(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 	Helvetica)�6+   �� 5       � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5       $��3* �6   �� 5!      $��55 �6   �� 5"      $��55 �6   �� 5#      $��* �6   	 � ColumnDefinitions	 5%   
   �� 5&      �� 5'      .+�5*   
   �� 
 �� CornerRadius$
 20��6   $��2��5+      $��4��5,      ��5-      �� 5.      .��5/      �  � Color$ #7be9f6��6#    � Offset$	 0.1Q�63   � 50      $ 	LawnGreen��6#   $	 1.0Q�65   51      53      �� 56   
   $��../Images/AddPerson.png��6   $��2��57      �� 59   
   $��_Name��6   $��0��5:      $��	70,10,0,0q�5;      $��1��5<       �� Target 5=      ��  �� ElementName$ nameTextBox���� 5?   
   $��_Date of birth��6   $��0��5@      $��	70,10,0,0q�5A      $��2��5C       5B      �� $ birthdayDatePicker��5C      �� 5E   
   -   5         ��Name$ nameTextBox��5H      $��1��5E      $��1��5F      $	��200��5G      $��8q�5I      (  "System.Windows.Controls.DatePicker  5K   
   -   5          Name$ birthdayDatePicker��5M      $��2��5K      $��1��5L      $	��200��5N      $��30��5O      $��0,15,0,0q�5P      �� 5R   
   -   5         ��Name$ AddPersonButton��5Z      $��Add a person��5R      $��3��5S      $��0��5T      $	��100��5U      $��35��5V      $��50,0,0,0q�5W       �� 	IsDefault$
 True��5X      5Z      �� 5\   
   -   5        $��Close window��5\      $��3��5]      $��1��5^      $	��100��5_      $��35��5`      $��0,0,50,0q�5a       �� IsCancel$
 True��5c      5e      5f      
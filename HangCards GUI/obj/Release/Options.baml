   M S B A M L   `   `   `  ���� H  DHangCards GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangCards_GUIHangCards_GUI      HangCards_GUI.Options   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     +srcclr-namespace:HangCards_GUI       � Title$  Options��$	��345��$	��434�� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $��58 ��� $��20 ��� �� $��42 �.+��� $��0�����#C40D42.+��� $��56�� �� Left$ 0��
 �� Top$ 0��$��UniformToFill=�$��.\Images\Banner.png���� $��Options�� �� Right$ 10��$ 13�����	#FFF7EFEF$��Times New Roman)�$��24(�$
��Bold"��� $��1��
���   � � 	Resources #   HangCards_GUI.NumberOfPlayers   numberOfPlayersData��%   &	          .+��� $��2��$ 10��$ 2��$	��408��$	��208��.@��� $
��Game��.��� ���	#FFE5E5E5.+��� -   $��playAgainstComputerCheck��$��Play against computer��$
��Left=�$��	11,33,0,0q�$	��Top=� d� 	IsChecked ��  �� Path$ PlayAgainstComputer��� $��Number of players��$
��Left=�$��	10,54,0,0q�$	��Top=��� -   $��numberOfPlayersComboBox��$
��Left=�$��
196,58,0,0q�$	��Top=�$��86������ 	 �� Source#	 [  
 �� SelectedValue
 �� $ NumberOfPlayers��� $"��Time allowed for each player��$
��Left=�$��	10,85,0,0q�$	��Top=��� -   $��timeAllowedTextBox��$
��Left=�$��
196,87,0,0q� �� TextWrapping$ WrapWithOverflow=�$	��Top=�$��86�� �� TextAlignment$ Center=����� $ MinutesBeforeLoss��� $��Minutes��$
��Left=�$��
287,85,0,0q�$	��Top=��� $��Computer Player��.��� ���	#FFE5E5E5.+��� $��Skill Level��$
��Left=�$��	10,10,0,0q�$	��Top=�	� -   $��dumbAIRadioButton��$
��Dumb��$
��Left=�$��	37,41,0,0q�$	��Top=�$
 TrueY�	� -   $��goodAIRadioButton��$
��Good��$
��Left=�$��	37,62,0,0q�$	��Top=�	� -   $��cheatingAIRadioButton��$��Cheats��$
��Left=�$��	37,83,0,0q�$	��Top=��� $��3�� �� Orientation$ 
Horizontal=�$��RightToLeft=�.+��� -   $��cancleButton��$��_Cancle��$��22��$��75��$��10,0,0,0q��� -   $��okButton��$	��_OK��$��22��$��75��$��10,0,0,0q�
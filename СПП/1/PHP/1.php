
<html>
 
<body>
	<head>
 <div class="form-group">
	<title>8ВМ82 Бокижонов А.К.</title>

	</head>
<h3>Программа X + Y </h3>
<label for="inp_1">Задача:&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</label>
<?php
$random_1 = mt_rand(1, 100);
$random_2 = mt_rand(1, 100);
{
echo " " .$random_1. "+"  .$random_2. '<br/>'
} 
?>
<form method="post"><br>

 
Ваш ответ:&nbsp; &nbsp;&nbsp;<input type="text" name="str1"><br/>
<input type="submit" value="Проверить" name="Submit"><br>
 
<?php
 if (isset($_POST['submit'])) {
 $NAME = $_POST["name"];
 
 echo "Name is = ". $NAME .'</br>';
 
 }
 ?>
 
</form>
</body>
</html>
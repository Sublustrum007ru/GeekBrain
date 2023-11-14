<?php
   $ot = 0;
   $not = 0;
      if ($_POST[q1] == a){$ot++;} else {$not++;}
      if ($_POST[q2] == a){$ot++;} else {$not++;}
?>
<!DOCTYPE HTML>
<html>
<head>
</head>
<body>
    <p>Правильных ответов: <?php echo $ot; ?> </p>
    <p>Неправильных ответов: <?php echo $not; ?> </p>
</body> 
</html>
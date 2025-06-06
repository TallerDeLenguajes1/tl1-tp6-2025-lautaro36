[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

¿String es una tipo por valor o un tipo por referencia?
es tipo por referencia porque es una clase

¿Qué secuencias de escape tiene el tipo string?
\'	Comilla simple (')
\"	Comilla doble (")
\\	Barra invertida
\n	Nueva línea / Salto de línea
\t	Tabulación horizontal
\r	Retorno de carro
\b	Retroceso (backspace)
\f	Salto de página (form feed)
\v	Tabulación vertical	
\0	Carácter nulo
\uXXXX	Carácter Unicode (UTF-16)
\xXX	Carácter Unicode (hexadecimal)

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando pones @ antes de una cadena de texto, la conviertes en un literal de cadena textual (verbatim string). Esto tiene los siguientes efectos:
Ignora secuencias de escape, excepción: Para incluir una comilla doble (") dentro de una cadena textual, debes escribirla dos veces (""), permite saltos de linea.

Cuando pones $ antes de una cadena de texto, la conviertes en una cadena interpolada (interpolated string). Esto te permite:
Incrustar expresiones directamente: Puedes insertar variables, constantes o cualquier expresión de C# directamente dentro de la cadena, encerrándolas entre llaves {}. El valor de la expresión se convertirá automáticamente a su representación de cadena.
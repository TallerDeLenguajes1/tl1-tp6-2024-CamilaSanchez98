### ¿String es un tipo por valor o un tipo por referencia?

En C#, `string` es un tipo por referencia. Aunque es inmutable, se comporta como otros tipos por referencia en cuanto a almacenamiento y manejo de memoria.

### ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape comunes en `string` en C# incluyen:
- `\\` : Barra invertida
- `\"` : Comilla doble
- `\n` : Nueva línea
- `\r` : Retorno de carro
- `\t` : Tabulador
- `\b` : Retroceso
- `\f` : Avance de página
- `\v` : Tabulador vertical
- `\uXXXX` : Carácter Unicode

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

**Carácter `@` (verbatim string literal)**:
- Permite cadenas de texto que pueden contener caracteres de escape literalmente (excepto `""` que representa una comilla doble dentro de la cadena).
- Ejemplo: `@"C:\Directorio\Archivo.txt"`

**Carácter `$` (interpolated string)**:
- Permite insertar expresiones dentro de la cadena usando `{}`.
- Ejemplo: `$"El valor es {valor}"`

**Combinación `@$` o `$@`**:
- Permite usar tanto verbatim string literals como interpolated strings.
- Ejemplo: `@$"Directorio: {path}\Archivo.txt"`

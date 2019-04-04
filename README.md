# BootstrapDocumentation

Anotações relevantes da documentação do Bootstrap 4

## Visão geral

### A classe container

Para containers de largura fixa _.container_, as alterações de tamanho de largura
(max-width) só ocorrem em cada breakpoint. Esse tipo de container é responsável por 
manter os elementos dentro dele centralizados horizontalmente na página.

Para containers de largura fluida _.container-fluid_ a largura ocupa 100% o tempo 
todo).

### Grid

#### Quebra de colunas com largura automática

Para quebrar colunas com largura automática utilize a classe _w-100_ em uma nova 
div antes da coluna que quer quebrar

#### Alinhamento vertical

Para o alinhamento vertical utilizamos o termo _align_. Para ver as alterações, é 
necessário *definir a altura da linha*.

Para alinhar *todos os itens contidos na linha*, utilize a classe _align-itens_, 
*na div da row*. As variações dessa classe são _start_, _center_ e _end_.

Para alinhar *apenas um item* utilize a classe _align-self_, *na div da coluna*. 
As variações dessa classe são _start_, _center_ e _end_. 

#### Alinhamento horizontal

Para o alinhamento horizontal utilizamos o termo _justify-content_. As variações 
dessa classe são _start_, _center_, _end_, _around_ e _between_. 



CREATE PROCEDURE [dbo].[SP_Listar] as
SELECT a.Id, Codigo, Nombre, a.Descripcion, m.Id as IdMarca, m.Descripcion AS Marca, c.Id as IdCategoria,
 c.Descripcion AS Categoria, Precio, i.ImagenUrl 
 FROM ARTICULOS a
  INNER JOIN MARCAS m ON  a.IdMarca = m.Id 
  INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id 
  LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo
GO

CREATE PROCEDURE  [dbo].[SP_FiltrarArticulos] 
(
    @palabraABuscar VARCHAR (100) 
) as
BEGIN

    SELECT a.Id, Codigo, Nombre, a.Descripcion, m.Id as IdMarca, m.Descripcion AS Marca, c.Id as IdCategoria,
    c.Descripcion AS Categoria, Precio, i.ImagenUrl 
    FROM ARTICULOS a
    INNER JOIN MARCAS m ON  a.IdMarca = m.Id 
    INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id 
    LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo
    WHERE a.Nombre like '%' + @palabraABuscar + '%' 
    OR m.Descripcion like '%' + @palabraABuscar + '%' 

END
GO

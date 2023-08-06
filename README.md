# **InteractiveScottPlot**
This demo app showcases some functionalities to make your WinForms plots more interactive using **ScottPlot** (v 4.1.65).
New features are planned to be added with time. 

*Disclaimer*: everything needs refactoring and there are most certainly many other ways to do these things more efficiently. Consider these demos as a simple way to showcase that these features can be implemented with ScottPlot.   

## How to use

Either build from source or download the executable from [here](https://drive.google.com/drive/folders/1_kgA5SSh7CUCsguNE2K13mXm84SbXpBL?usp=sharing) (you need to download the whole folder). 

## Demo features so far

- ##### Clickable ScatterPlot

For large datasets, creating a single clickable `MarkerPlot` for each point is too slow. `ClickableScatterPlot` leverages `ScatterPlot`'s faster rendering. You can retrieve relevant data from the selected point.

![ClickableScatterPlotGif](https://github.com/gabrielgcma/InteractiveScottPlot/assets/93090939/72179590-7e8e-41b6-a907-a54331de678c)

## To be added:

- ##### Selection Polygon

Sometimes you want the user to have fine-grained control over a dataset. This feature allows the user to create a polygon from which points will be filtered out.

- ##### Interactive Region

An interactive rectangular region from which points can also be filtered out.







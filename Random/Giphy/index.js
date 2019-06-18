const key = 'MeW1kajtnoTG10X0sbWqFaVjE97pKr85'

let form = document.getElementById("gif-form")

form.addEventListener('submit', function(event){
  event.preventDefault()

  fetchGif(this.children[0].value)
})

function fetchGif(searchText){
  const url ='someurl_'
  fetch(url)
  .then(function(response){
    return response.json()
  })
  .then(function(object) {
    let gifUrl = object.data[0].images.original.url
    const img = document.getElementById('gif-img')
    img.srs = gifUrl
  })
}

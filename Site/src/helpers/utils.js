export const Months = ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro']

export const dateToString = date => {
  if (!date)
    date = new Date()
  else if (typeof (date) === 'string')
    date = new Date(date)

  let day = date.getDate()
  day = day > 9 ? day : '0' + day

  let month = date.getMonth() + 1
  month = month > 9 ? month : '0' + month

  return `${day}/${month}/${date.getFullYear()}`
}

export const getDateFromStringEg = (value) => {
  if (!value)
    return null

  const date = value.split('-')
  const year = date[0]
  const month = date[1]
  new Date('2002/10')
  return new Date(`${year}/${month}`)
}

export const toReal = val => {
  return isNaN(val) ? val : `R$ ${Number(val)
    .toFixed(2).replace('.', ',')
    .replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}`
}

export const fromReal = val => typeof (val) === 'string' ? Number((val || '').replace(/[^0-9,]/g, '').replace(',', '.') || 0) : val

export const isSameMonth = (d1, d2) => {
  const date1 = new Date(d1)
  const date2 = new Date(d2)
  if (date1 === 'Invalid Date' || date2 === 'Invalid Date')
    return false
  return date1.getMonth() === date2.getMonth()
    && date1.getFullYear() === date2.getFullYear()
}

export const getMonthYear = (date) => {
  const d = date.split('/')
  return `${Months[Number(d[0]) - 1]} - ${d[1]}`
}

export const debounce = (callback, delay) => {
  let timer
  return (...args) => {
    clearTimeout(timer)
    timer = setTimeout(() => callback(...args), delay)
  }
}
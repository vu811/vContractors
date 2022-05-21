import React from 'react'
import styles from '../styles/Home.module.scss'

export default function Home() {
  return (
    <>
      <div className={styles.home}>
        <div className={styles.sampleBox}>
          <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer porta nisl quis pharetra lacinia. Aliquam porttitor urna eu egestas condimentum. Mauris volutpat
            egestas erat, vel scelerisque neque dapibus a. Nullam tristique dignissim nisl, vel faucibus magna pharetra ut. Fusce pretium faucibus ligula, sit amet porta neque.
            Pellentesque non orci vitae ipsum lacinia imperdiet sit amet quis quam. Vestibulum vel tristique ante, non porta erat. Phasellus rhoncus nisl enim, eu elementum lorem
            fringilla id. Maecenas ornare imperdiet ipsum eu dictum. Cras malesuada sapien at purus pellentesque cursus. Donec quam tortor, interdum vitae efficitur dignissim,
            semper sit amet ex. Nulla ultrices, lacus eu porttitor hendrerit, dolor urna tempus felis, ac commodo quam urna id sem. Integer varius risus vel lectus ornare viverra.
            Aliquam eget sodales odio, tincidunt posuere libero.
          </p>
          <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer porta nisl quis pharetra lacinia. Aliquam porttitor urna eu egestas condimentum. Mauris volutpat
            egestas erat, vel scelerisque neque dapibus a. Nullam tristique dignissim nisl, vel faucibus magna pharetra ut. Fusce pretium faucibus ligula, sit amet porta neque.
            Pellentesque non orci vitae ipsum lacinia imperdiet sit amet quis quam. Vestibulum vel tristique ante, non porta erat. Phasellus rhoncus nisl enim, eu elementum lorem
            fringilla id. Maecenas ornare imperdiet ipsum eu dictum. Cras malesuada sapien at purus pellentesque cursus. Donec quam tortor, interdum vitae efficitur dignissim,
            semper sit amet ex. Nulla ultrices, lacus eu porttitor hendrerit, dolor urna tempus felis, ac commodo quam urna id sem. Integer varius risus vel lectus ornare viverra.
            Aliquam eget sodales odio, tincidunt posuere libero.
          </p>
          <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer porta nisl quis pharetra lacinia. Aliquam porttitor urna eu egestas condimentum. Mauris volutpat
            egestas erat, vel scelerisque neque dapibus a. Nullam tristique dignissim nisl, vel faucibus magna pharetra ut. Fusce pretium faucibus ligula, sit amet porta neque.
            Pellentesque non orci vitae ipsum lacinia imperdiet sit amet quis quam. Vestibulum vel tristique ante, non porta erat. Phasellus rhoncus nisl enim, eu elementum lorem
            fringilla id. Maecenas ornare imperdiet ipsum eu dictum. Cras malesuada sapien at purus pellentesque cursus. Donec quam tortor, interdum vitae efficitur dignissim,
            semper sit amet ex. Nulla ultrices, lacus eu porttitor hendrerit, dolor urna tempus felis, ac commodo quam urna id sem. Integer varius risus vel lectus ornare viverra.
            Aliquam eget sodales odio, tincidunt posuere libero.
          </p>
        </div>
      </div>
    </>
  )
}

// This gets called on every request
export async function getServerSideProps() {
  // Fetch data from external API
  const res = await fetch('http://vcontractors.vn/WeatherForecast')
  const data = await res.json()
  console.log(data)

  // Pass data to the page via props
  return { props: { data } }
}

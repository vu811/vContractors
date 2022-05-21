import React from 'react'
import Footer from './footer'
import Header from './header'
import { Container } from 'semantic-ui-react'
import styles from './scss/DefaultLayout.module.scss'

const DefaultLayout = ({ children }) => {
  return (
    <>
      <Header />
      <main className={styles.main}>
        <Container>{children}</Container>
      </main>
      <Footer />
    </>
  )
}

export default DefaultLayout

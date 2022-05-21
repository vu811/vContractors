import styles from './scss/Header.module.scss'
import { Container, Grid } from 'semantic-ui-react'

const Header = () => {
  return (
    <header className={styles.header}>
      <Container className={styles.headerContainer}>
        <Grid className={styles.grid}>
          <Grid.Column width={4} className={styles.logo}>
            <div>NHATHAUVIET</div>
          </Grid.Column>
          <Grid.Column width={12}></Grid.Column>
        </Grid>
      </Container>
    </header>
  )
}

export default Header
